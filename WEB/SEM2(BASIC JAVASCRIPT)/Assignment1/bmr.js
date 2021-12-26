// JavaScript source code
function metricBMR() {
    var bmr = 0;
    var pal = 0;
    var tee = 0;
    var name = document.getElementById("name").value;
    var gender = document.getElementById("gender").value;
    var age = document.getElementById("age").value;
    var height = document.getElementById("height").value;
    var weight = document.getElementById("weight").value;
    var activity1 = document.getElementById("activityLevel1");
    var activity2 = document.getElementById("activityLevel2");
    var activity3 = document.getElementById("activityLevel3");

    (activity1.checked) ? (pal += 1.53) : (pal += 0);
    (activity2.checked) ? (pal += 1.76) : (pal += 0);
    (activity3.checked) ? (pal += 2.25) : (pal += 0);

    (gender === "Male") ? (bmr += (66.5 + (13.75 * weight) + (5.003 * height) - (6.755 * age))) : (bmr += 0);
    (gender === "Female") ? (bmr += (655 + (9.563 * weight) + (1.850 * height) - (4.676 * age))) : (bmr += 0);

    tee = bmr * pal;

    document.write("<p>Hello " + name + "<p>\n");
    document.write("<p>You are " + gender + "</p >\n");
    document.write("<p>You are " + age + " years old.</p>\n");
    document.write("<p>You weigh " + weight + " kilogram</p>\n");
    document.write("<p>You are " + height + " cm tall</p>\n");
    document.write("<p> Your BMR is: " + bmr + "\n</p>");
    document.write("<p> You TEE or daily calorie intake is " + tee + "\n</p>");

}
document.getElementById("submitMetric").addEventListener("click", metricBMR, false);

function imperialBMR(){
    var bmr = 0;
    var pal = 0;
    var tee = 0;
    var name = document.getElementById("name").value;
    var gender = document.getElementById("gender").value;
    var age = document.getElementById("age").value;
    var height = document.getElementById("height").value;
    var weight = document.getElementById("weight").value;
    var activity1 = document.getElementById("activityLevel1");
    var activity2 = document.getElementById("activityLevel2");
    var activity3 = document.getElementById("activityLevel3");

    (activity1.checked) ? (pal += 1.53) : (pal += 0);
    (activity2.checked) ? (pal += 1.76) : (pal += 0);
    (activity3.checked) ? (pal += 2.25) : (pal += 0);

    (gender == "male") ? (bmr = (66 + (6.2 * weight) + (12.7 * height) - (6.76 * age))) : (bmr = 0);
    (gender == "female") ? (bmr = (655 + (4.35 * weight) + (4.7 * height) - (4.7 * age))) : (bmr = 0);

    tee = bmr * pal;

    document.write("<p>Hello " + name + "<p>\n");
    document.write("<p>You are " + gender + "</p >\n");
    document.write("<p>You are " + age + " years old.</p>\n");
    document.write("<p>You weigh " + weight + " kilogram</p>\n");
    document.write("<p>You are " + height + " cm tall</p>\n");
    document.write("<p> Your BMR is: " + bmr + "\n</p>");
    document.write("<p> You TEE or daily calorie intake is " + tee + "\n</p>");


} document.getElementById("submitImperial").addEventListener("click", imperialBMR, false);
