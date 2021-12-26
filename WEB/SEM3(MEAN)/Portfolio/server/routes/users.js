let express = require('express');
let router = express.Router();
let mongoose = require('mongoose');

let jwt = require('jsonwebtoken');

let passport = require('passport');

let userController = require('../controllers/users');

//helper function for guard purposes
function requireAuth(req, res, next){
    //check if the user is logged in 
    if(!req.isAuthenticated()){ 
        return res.redirect('/users/login')
    }
    next();
}
// GET ROUTE FOR BUSINESS LIST PAGE - READ OPERATION
router.get('/list', requireAuth, userController.displayUserList);

// GET ROUTE FOR DISPLAYING LOGIN PAGE 
router.get('/login', userController.displayLoginPage);

/* POST Route for processing the LOGIN page*/
router.post('/login', userController.processLoginPage);

/* GET Route for DISPLAYING the REGISTER page*/
router.get('/register', userController.displayRegisterPage);

/* POST Route for processing the REGISTER page*/
router.post('/register', userController.processRegisterPage);

/* GET to perform user LOGOUT*/
router.get('/logout', requireAuth, userController.performLogout);
 
/* GET Route for DISPLAYING the UPDATE page - UPDATE OPERATION*/
router.get('/update/:id', requireAuth, userController.displayUpdatePage);

/* POST Route for PROCESSING the UPDATE page - UPDATE OPERATION*/
router.post('/update/:id', requireAuth, userController.processUpdatePage);

/* GET to perform book DELETION - DELETE OPERATION*/
router.get('/delete/:id', requireAuth, userController.performDelete);

module.exports = router;