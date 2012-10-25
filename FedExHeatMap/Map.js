$(function () {
    
    var sanFrancisco = new google.maps.LatLng(16.130262, -5.449219);

    var map = new google.maps.Map(document.getElementById('map_canvas'), {
        center: sanFrancisco,
        zoom: 2,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });
    

});