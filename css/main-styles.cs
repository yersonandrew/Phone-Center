.header .btn-primary {
  color: #ffffff;
  text-decoration: none;
  display: inline-block;
  padding: 0.5rem 2.5rem;
  font-size: 1.8rem;
  background-color: #797a7c;
  transition: all 0.4s ease-in-out;
  border-radius: 25px;
}
.header .btn-primary:hover {
  background-color: #3e3e41;
}

/*
*HEADER
*
*/
.header {
  margin-top: 70px;
  height: 80vh;
  position: relative;
}
.header__container {
  height: 100%;
  background-image: linear-gradient(to right bottom, rgba(72, 85, 99, 0.5), rgba(41, 50, 60, 0.5)), url(../img/hero-1.jpg);
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
}
.header__description {
  color: #ffffff;
  display: flex;
  flex-direction: column;
  padding-top: 20px;
  justify-content: start;
  text-align: center;
  max-width: 98%;
  height: 100%;
  margin-left: auto;
  margin-right: auto;
}
.header__title {
  margin: 0;
  font-family: "Allerta Stencil", sans-serif;
  font-size: 6rem;
  font-weight: 300;
}
.header__parrafo {
  font-size: 1.8rem;
  margin: 0;
}
.header .btn {
  margin-top: 2rem;
}
.header__wave {
  width: 100%;
  position: absolute;
  bottom: -1px;
  right: 0;
}

/*
*menu navegacion
*/
.nav {
  position: fixed;
  z-index: 1000;
  width: 40%;
  height: 100vh;
}
.nav__main-menu {
  width: 100%;
  height: 70px;
  display: flex;
  justify-content: space-around;
  align-items: center;
  position: fixed;
  top: 0;
  z-index: 1000;
  background-color: rgba(255, 255, 255, 0.877);
}
.nav__img {
  position: relative;
  padding: 10px;
  width: 20%;
  object-fit: cover;
  transition: 0.3s ease-in-out;
}
@media only screen and (min-width: 320px) {
  .nav__img {
    width: 50%;
  }
}
@media only screen and (min-width: 760px) {
  .nav__img {
    width: 40%;
  }
}
@media only screen and (min-width: 900px) {
  .nav__img {
    width: 30%;
  }
}
@media only screen and (min-width: 1200px) {
  .nav__img {
    width: 20%;
  }
}
.nav__img:hover {
  opacity: 1;
  cursor: pointer;
}
.nav__item-icon {
  font-size: 3rem;
}
.nav__item-icon:hover {
  cursor: pointer;
}
.nav__principal {
  width: 40%;
  height: 100vh;
  background-color: #ffffff;
  transform: translateX(-100%);
  transition: all 0.5s cubic-bezier(0.19, 1.02, 0.96, 0.86);
}
.nav__list {
  margin: 0;
  position: absolute;
  top: 100px;
  list-style: none;
  z-index: 10;
}
.nav__link {
  color: gray;
  text-decoration: none;
  font-size: 2rem;
}

/*
*contenido preincipal
*/
.nosotros {
  margin-bottom: 3rem;
  width: 100%;
}
.nosotros__container {
  max-width: 85%;
  margin-left: auto;
  margin-right: auto;
  display: flex;
  flex-direction: column;
}
@media only screen and (min-width: 900px) {
  .nosotros__container {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    grid-template-rows: repeat(3, 1fr);
    gap: 5px;
  }
}
.nosotros__title {
  font-size: 4rem;
  font-family: "Allerta Stencil", sans-serif;
  margin: 0;
  font-weight: 300;
}
.nosotros__parrafo {
  font-size: 1.5rem;
}
.nosotros__img {
  max-width: 100%;
  max-height: 100%;
  object-fit: cover;
}
.nosotros__item {
  text-align: center;
}
@media only screen and (min-width: 760px) {
  .nosotros__item {
    height: 250px;
  }
}
.nosotros__item--1 {
  grid-row: 1/2;
  grid-column: 2/span 2;
}
.nosotros__item--2 {
  grid-column: 1/span 2;
}
.nosotros__item--3 {
  grid-column: 3/span 2;
}
.nosotros__item--4 {
  grid-column: 1/span 2;
}
.nosotros__item--5 {
  grid-column: 3/span 2;
}

/*****
*servicios
*/
.services {
  height: 80vh;
  width: 100%;
}
.services__title {
  text-align: center;
  margin: 0;
  font-family: "Allerta Stencil", sans-serif;
  font-weight: 300;
  font-size: 4rem;
}
.services__img {
  width: 100%;
  height: 100%;
  position: relative;
  border-radius: 20px;
  object-fit: cover;
  transition: all 0.3s ease-in-out;
}
.services__img:hover {
  cursor: pointer;
  transform: scale(1.1);
  filter: grayscale(0.5);
  -webkit-box-shadow: -1px -1px 20px -3px black;
  -moz-box-shadow: -1px -1px 20px -3px black;
  box-shadow: -1px -1px 20px -3px black;
}
.services__description {
  position: absolute;
  top: 0;
  left: 0;
}
.services__title-item {
  font-size: 5rem;
}
.services__container {
  width: 80%;
  height: 80vh;
  margin: 0 auto;
}
@media only screen and (min-width: 760px) {
  .services__container {
    display: grid;
    grid-template-columns: repeat(6, 1fr);
    grid-template-rows: repeat(11, 1fr);
    column-gap: 50px;
  }
}
.services__grid {
  margin-top: 1rem;
}
.services__grid--1 {
  grid-column: 1/3;
  grid-row: 1/span 8;
}
.services__grid--2 {
  grid-column: 3/span 2;
  grid-row: 2/span 8;
}
.services__grid--3 {
  grid-column: 5/span 2;
  grid-row: 3/span 8;
}

html {
  box-sizing: border-box;
  font-size: 62.5%;
}

body {
  font-family: sans-serif;
  font-weight: 400;
  line-height: 1.6;
  background-color: #f2f2f2;
}

/*# sourceMappingURL=main-styles.cs.map */
