const router = require('express').Router();

// import controllers
const test = require('../controllers/api');
const api = require('../controllers/api');

// get route
router.get('/test', test.test);
router.get('/api', api.getapi)

// post route





// exports
module.exports = router;