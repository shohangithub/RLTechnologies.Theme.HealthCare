$(document).ready(function () {
	// jQuery methods go here...
	console.log("jquery loaded");

	new Swiper(".products__list", {
		centerInsufficientSlides: true,
		loop: true,
		slidesPerView: "auto",
		observeParents: true,
		navigation: {
			nextEl: ".swiper-button-next",
			prevEl: ".swiper-button-prev",
		},
		breakpoints: {
			0: {
				spaceBetween: 12,
			},
			768: {
				spaceBetween: 30,
			},
		},
	});

	const numericInputs = document.querySelectorAll("[data-numeric]");
	console.log(numericInputs);

	numericInputs.forEach((input) => {
		input.addEventListener("input", function () {
			this.value = this.value.replace(/[^0-9]/g, "");
		});
	});

	new Swiper(".clients__list ", {
		spaceBetween: 50,
		slidesPerView: 3,
		loop: true,
		centeredSlides: true,
		centeredSlidesBounds: true,
		navigation: true,
		navigation: {
			nextEl: ".swiper-button-next",
			prevEl: ".swiper-button-prev",
		},

		breakpoints: {
			0: {
				slidesPerView: 1.4,
				spaceBetween: 50,
			},
			768: {
				spaceBetween: 50,
				slidesPerView: 3,
			},
		},
	});

	const swiper = new Swiper(".thumbs", {
		spaceBetween: 10,
		slidesPerView: 3,
		loop: false,
		centeredSlides: true,
		centeredSlidesBounds: true,
		navigation: {
			nextEl: ".swiper-button-next",
			prevEl: ".swiper-button-prev",
		},
	});

	new Swiper(".product-images__slider", {
		spaceBetween: 10,
		loop: false,
		thumbs: {
			swiper: swiper,
		},
	});

	$(window).scroll(function () {
		if ($(this).scrollTop() > 100) {
			$("#go-top").fadeIn();
		} else {
			$("#go-top").fadeOut();
		}
	});

	$("#go-top").click(function () {
		$("html, body").animate({ scrollTop: 0 }, "300");
		return false;
	});
	$(".toggle-menu").click(function () {
		$(".main-menu").toggleClass("show-menu");

		var icon = $(this).find("i");
		if (icon.hasClass("icon-hamburger-menu")) {
			icon.removeClass("icon-hamburger-menu").addClass("icon-cross");
		} else {
			icon.removeClass("icon-cross").addClass("icon-hamburger-menu");
		}
	});
});
