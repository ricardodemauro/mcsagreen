// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

class GeoFields {

    constructor(fieldIdLatitutde, fieldIdLongitude, showMapIn = '') {
        this.__fieldIdLatitude = fieldIdLatitutde;
        this.__fieldIdLongitude = fieldIdLongitude;
        this.__showMapIn = showMapIn;
    }

    getLocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(this.setLocation.bind(this));
        }
    }

    setLocation(position) {
        console.log(`location found lat ${position.coords.latitude} and long ${position.coords.longitude}`);

        if (position && position.coords) {
            document.getElementById(this.__fieldIdLatitude).value = position.coords.latitude;
            document.getElementById(this.__fieldIdLongitude).value = position.coords.longitude;

            if (this.__showMapIn) {
                const urlFrame = `https://www.bing.com/maps/embed?h=400&w=500&cp=${position.coords.latitude}~${position.coords.longitude}&lvl=13&typ=d&sty=r&src=SHELL&FORM=MBEDV8`;
                console.log('url frame ' + urlFrame);

                const gFrame = document.createElement('iframe');
                gFrame.src = urlFrame;
                gFrame.width = 600;
                gFrame.height = 450;
                gFrame.frameBorder = 0;
                gFrame.style.border = 0;

                document.getElementById(this.__showMapIn).appendChild(gFrame);
            }
        }
    }
}