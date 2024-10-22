document.addEventListener("DOMContentLoaded", function ()
{
    var carousel = document.getElementById('slider');
    var carouselInstance = new bootstrap.carousel(carousel, {
        interval: 2000,
    });
});