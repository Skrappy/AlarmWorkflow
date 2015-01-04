/// <reference path="..\Scripts\jquery-2.1.3.js" />
"use strict";

if (var_awOperation === null && var_awSource === null) {

    var_awSource = {
        Street: "Karlstraße",
        StreetNumber: "5",
        City: "München",
        ZipCode: "80335"
    };

    var_awOperation = {
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

var routeSrc = "";
routeSrc += "http://maps.google.com/maps/api/directions/json?sensor=false";
routeSrc += "&origin=" + encodeURIComponent(getLocationString(var_awSource));
routeSrc += "&destination=" + encodeURIComponent(getLocationString(var_awOperation.Einsatzort));

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
    if (typeof window.external.setReady != "undefined") {
        window.external.setReady();
    }
});