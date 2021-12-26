let express = require('express');
let router = express.Router();
let mongoose = require('mongoose');
let passport = require('passport');
//let = require('jsonwebtoken');

//create reference to model
let userModel = require('../models/users');
let User = userModel.User;

module.exports.displayUserList = (req, res, next) => {
    User.find((err, userList) => {
        if(err){
            console.log(userList);
            return console.error(err);
        }
        else{
            console.log(userList);
            res.render('auth/list', 
            {title: 'Business Contacts List', 
            UserList: userList, 
            displayName: req.user ? req.user.displayName : ''});
        }
    });
}

module.exports.displayUpdatePage = (req, res, next) => {
    let id = req.params.id;

    User.findById(id, (err, userToEdit) => {
        if(err){
            console.log(err);
            res.end(err);
        }
        else{
            //show the edit view
            res.render('auth/update', 
            {title: 'Update User', 
            user: userToEdit,
            displayName: req.user ? req.user.displayName : ''});
        }
    });
}

module.exports.processUpdatePage = (req, res, next) => {
    let id = req.params.id;

    let updatedUser = User({
        "_id": id,
        "displayName": req.body.displayName,
        "username": req.body.username,
        "password": req.body.password,
        "email": req.body.email,
        "phone": req.body.phone
    });

    User.updateOne({_id: id}, updatedUser, (err) => {
        if(err){
            console.log(err);
            res.end(err);
        }
        else{
            //refresh the user list
            res.redirect('/users/list');
        }
    });
}

module.exports.performDelete = (req, res, next) => {
    let id = req.params.id;

    User.remove({_id:id}, (err) => {
        if(err){
            console.log(err);
            res.end(err);
        }
        else{
            //refresh the user list
            res.redirect('/users/list');
        }
    });
}

module.exports.performLogout = (req, res, next) => {
    req.logout();
    res.redirect('/');
}

module.exports.displayLoginPage = (req, res, next) => {
    //check if user already logged in
    if(!req.user){
        res.render('auth/login', {
            title: "Login",
            messages: req.flash('loginMessage'),
            displayName: req.user ? req.user.displayName : ''
        });
    }
    else{
        return res.redirect('/');
    }
}

module.exports.processLoginPage = (req, res, next) => {
    passport.authenticate('local',
    (err, user, info) => {
        //server error?
        if(err){
            return next(err);
        }
        //is there a user login error?
        if(!user){
            req.flash('loginMessage', 'Authentication Error');
            return res.redirect('/users/login');
        }
        req.login(user, (err) => {
            //server error
            if (err) {
                return next(err);
            }
            return res.redirect('/');
        });
    })(req, res, next);
}

module.exports.displayRegisterPage = (req, res, next) => {
    //check if the user is already logged in 
    if(!req.user){
        res.render('auth/register', {
            title: 'Register',
            messages: req.flash('registerMessage'),
            displayName: req.user ? req.user.displayName : ''
        });
    };
}

module.exports.processRegisterPage = (req, res, next) => {
    //instantiate a user object
    let newUser = new User({
        username: req.body.username,
        //password: req.body.password,
        email: req.body.email,
        displayName: req.body.displayName,
        phone: req.body.phone
    });

    User.register(newUser, req.body.password, (err) => {
        if(err){
            console.log("Error: Inserting new User");
            if(err.name == "UserExistsError"){
                req.flash(
                    'registerMessage',
                    'Registration Error: User already exists!'
                );
                console.log('Error: User already exists!');
            }
            return res.render('auth/register',
            {
                title: 'Register',
                messages: req.flash('registerMessage'),
                displayName: req.user ? req.user.displayName : ''
            });
        }
        else{
            //if no error exists, then registration is successful

            //redirect the user and authenticate them

            /* TODO - Getting ready to convert to API
            res.json({
                success: true,
                msg: 'User registered successfully!'
            });
            */

            return passport.authenticate('local')(req, res, () => {
                res.redirect('/');
            });
        }
    });
}