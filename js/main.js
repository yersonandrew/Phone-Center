// sidebar toggle
const btnToggle = document.querySelector('.sidebar__menu-boton');

btnToggle.addEventListener('click', function() {
    console.log('clik')
    document.getElementById('sidebar').classList.toggle('sidebar__active');
    console.log(document.getElementById('sidebar'))
});


const slides = document.querySelector(".header__slider").children;
const prev = document.querySelector(".header__izq");
const next = document.querySelector(".header__der");
let index = 0;


prev.addEventListener("click", function() {
    prevSlide();
})

next.addEventListener("click", function() {
    nextSlide();

})

function prevSlide() {
    if (index == 0) {
        index = slides.length - 1;
    } else {
        index--;
    }
    changeSlide();
}

function nextSlide() {
    if (index == slides.length - 1) {
        index = 0;
    } else {
        index++;
    }
    changeSlide();
}

function changeSlide() {
    for (let i = 0; i < slides.length; i++) {
        slides[i].classList.remove("header__active");
    }

    slides[index].classList.add("header__active");
}




var map = L.map('mapa').setView([51.505, -0.09], 13);

L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
}).addTo(map);

L.marker([51.5, -0.09]).addTo(map)
    .bindPopup('A pretty CSS3 popup.<br> Easily customizable.')
    .openPopup();