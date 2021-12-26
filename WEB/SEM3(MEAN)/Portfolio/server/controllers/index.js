let express = require('express');
let router = express.Router();
let mongoose = require('mongoose');
let passport = require('passport');

// create user model instance 
let userModel = require('../models/users');
let User = userModel.User;

/* GET home page. */
module.exports.displayHomePage = (req, res, next) => {
    res.render('index', { title: 'Home', displayName: req.user ? req.user.displayName : '' });
}
/* GET about page. */
module.exports.displayAboutPage = (req, res, next) => {
    res.render('about', { title: 'About', displayName: req.user ? req.user.displayName : '' });
}

/* GET products page. */
module.exports.displayProjectsPage = (req, res, next) => {
    res.render('projects', { title: 'Projects', displayName: req.user ? req.user.displayName : '' });
}

/* GET services page. */
module.exports.displayServicesPage = (req, res, next) => {
    res.render('services', { title: 'Services', displayName: req.user ? req.user.displayName : '' });
}

module.exports.displayContactPage = (req, res, next) => {
    res.render('contact', { title: 'Contact', displayName: req.user ? req.user.displayName : ''});
}
module.exports.downloadResume = (req, res, next) => {
    res.download('public/assets/files/DaniyalAhmedResume.pdf');
}