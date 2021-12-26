//require modules for the user model
let mongoose = require('mongoose');
let passportLocalMongoose = require('passport-local-mongoose');

let User = mongoose.Schema
(
    {
        displayName:
        {
            type: String,
            default: '',
            trim: true,
            required: 'display name is required'
        }
 ,
        username:
        {
            type:String,
            default: '',
            trim: true,
            required: 'username is required'
        },
        /*
        password:
        {
            type: String,
            default: '',
            trim: true,
            required: 'password is required'
        }
        */
       email:
       {
           type: String,
           default: '',
           trim: true,
           required: 'email is required'
       },
       phone:
       {
           type: String,
           default: '',
           trim: true,
           required: 'phone number is required'
       }

    },
    {
        collection: "users"
    }
);

//configure options for User Model

let options = ({missingPasswordError: 'Wrong / Missing Password'});

User.plugin(passportLocalMongoose, options);

module.exports.User = mongoose.model('User', User);