let newLayer = new ol.layer.Tile({
    source: new ol.source.OSM({
        url: 'E:/Maperitive/Tiles/vychod/{z}/{x}/{y}.png',
        crossOrigin: null
        })
    });