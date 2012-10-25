$(function () {
    
    var center = new google.maps.LatLng(16.130262, -5.449219);

    var map = new google.maps.Map(document.getElementById('map_canvas'), {
        center: center,
        zoom: 2,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    });

    var heatmap = new google.maps.visualization.HeatmapLayer();
    
    function getData() {
        $.get("/mapData").success(function(data) {
            var heatMapData = _(data).map(function(point) {
                return { location: new google.maps.LatLng(point.Latitude, point.Longitude), weight: point.Weight };
            });

            heatmap.setData(heatMapData);
            heatmap.setMap(map);
            setTimeout(getData, 5000);
        });
        
    }

    setTimeout(getData, 1000);

});