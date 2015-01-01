/// <reference path="..\Scripts\jquery-2.1.3.js" />
"use strict";

var awTestLocFrom = null;
var awTestOp = null;
if (var_awTestMode === true) {

    awTestLocFrom = {
        Street: "Karlstraße",
        StreetNumber: "5",
        City: "München",
        ZipCode: "80335"
    };

    awTestOp = {
        Comment: "Testkommentar",
        Einsatzort: {
            Street: "Hirtenstraße",
            StreetNumber: "5",
            City: "München",
            ZipCode: "80335"
        },
    };
}

function getLocationString(location) {
    return location.Street + " " + location.StreetNumber + ", " + location.ZipCode + " " + location.City;
}

var origin = (var_awTestMode) ? awTestLocFrom : window.external.Source;
var operation = (var_awTestMode) ? awTestOp : window.external.Operation;

var routeSrc = "";
routeSrc += "http://maps.google.com/maps/api/directions/json?sensor=false";
routeSrc += "&origin=" + encodeURIComponent(getLocationString(origin));
routeSrc += "&destination=" + encodeURIComponent(getLocationString(operation.Einsatzort));

$.getJSON(routeSrc, "", function (data) {
    var routePolylinePoints = data.routes[0].overview_polyline.points;

    var secondRequest = "";
    secondRequest += "http://maps.google.com/maps/api/staticmap?sensor=false";
    secondRequest += "&size=800x800";
    secondRequest += "&path=weight:3|color:red|enc:" + routePolylinePoints;

    var $routeImg = $("<img src='" + secondRequest + "' />");
    $("#route").replaceWith($routeImg);

    /* HINT: This is required so that the job can safely continue execution!
     */
    window.external.setReady();
});