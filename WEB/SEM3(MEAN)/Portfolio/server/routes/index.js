var express = require('express');
var router = express.Router();

let indexController = require('../controllers/index');
/* GET home page. 
router.get('/', function(req, res, next) {
  res.render('index', { title: 'Home'});
});*/

/* GET home page. */
router.get('/home',  indexController.displayHomePage);

/* GET home page. */
router.get('/',  indexController.displayHomePage);

/* GET about page. */
router.get('/about', indexController.displayAboutPage);

/* GET products page. */
router.get('/projects', indexController.displayProjectsPage);

/* GET services page. */
router.get('/services', indexController.displayServicesPage);

/* GET contact us page. */
router.get('/contact', indexController.displayContactPage);

router.get('/resume', indexController.downloadResume);

module.exports = router;
