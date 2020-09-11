$(".category-menu").menu();
$(".menu-mobile").menu();
$(".slide-wrap-1").owlCarousel({
    loop: true,
    nav: false,
    dots: true,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true,
    items: 1,
    speed: 2000,
    //animateOut: 'animate__animated animate__backOutLeft',
    //animateIn: 'animate__animated animate__backInRight',
});
$(".Feed-back .owl-carousel").owlCarousel({
    loop: true,
    nav: true,
    navText: ["<i class='fa fa-caret-left'></i>", "<i class='fa fa-caret-right'></i>"],
    dots: false,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true,
    speed: 2000,
    items: 1,
});
$('.fast-sell .owl-carousel').owlCarousel({
    loop: true,
    nav: true,
    navText: ["<i class='fa fa-caret-left'></i>", "<i class='fa fa-caret-right'></i>"],
    dots: false,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true,
    speed: 2000,
    responsive: {
        0: {
            items: 2
        },
        600: {
            items: 3
        },
        1000: {
            items: 4,
        },
        1400: {
            items: 5
        }
    }
});
$('.post-health .owl-carousel').owlCarousel({
    loop: true,
    nav: false,
    dots: false,
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true,
    speed: 2000,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 2
        },
        800: {
            items: 3
        }
    }
});
$('.owl-carousel').owlCarousel({
    loop: true,
    margin: 7.5,
    nav: true,
    navText: ["<i class='fa fa-caret-left'></i>", "<i class='fa fa-caret-right'></i>"],
    dots: false,
    autoplay: true,
    autoplayTimeout: 2000,
    autoplayHoverPause: true,
    speed: 2000,
    animateOut: 'animate__animated animate__backOutLeft',
    animateIn: 'animate__animated animate__backInRight',
    responsive: {
        0: {
            items: 2,
            nav: false,
        },
        768: {
            items: 3,
            nav: false,
        },
        1024: {
            items: 3
        },
        1200: {
            items: 4
        }
    }
});

$('.classify .post-wrapper').slick({
    centerMode: false,
    slidesToShow: 4,
    slidesToScroll: 4,
    infinite: true,
    rows: 2,
    autoplay: true,
    autoplaySpeed: 2000,
    speed: 1000,
    responsive: [
        {
            breakpoint: 1025,
            settings: {
                centerMode: false,
                slidesToShow: 3,
                slidesToScroll: 3,
            }
        },
        {
            breakpoint: 600,
            settings: {
                centerMode: false,
                slidesToShow: 2,
                slidesToScroll: 2,
                prevArrow: false,
                nextArrow: false
            }
        }
    ]
});
$('.post-wrapper .slick-prev.slick-arrow').html('<i class="far fa-chevron-left"></i>');
$('.post-wrapper .slick-next.slick-arrow').html('<i class="far fa-chevron-right"></i>');

var active = false;
function MobileAction() {
    if (active) {
        $(".menu-mobile").hide();
        $("#div-wrapper-body").hide();
        $(".menu-mobile").removeClass('animate__backInLeft');
        active = false;
    }
    else {
        $(".menu-mobile").show();
        $("#div-wrapper-body").show(); 
        $(".menu-mobile").addClass('animate__backInLeft');
        active = true;
    }
}
$("#div-wrapper-body").click(function () {
    $(".menu-mobile").hide();
    $("#div-wrapper-body").hide();
    $(".menu-mobile").removeClass('animate__backInLeft');
    $(".menu-mobile").addClass('animate__bounceOutLeft');
})


$("#slider-range").slider({
    range: true,
    min: 50000,
    max: 500000,
    step: 50000,
    values: [100000, 400000],
    slide: function (event, ui) {
        $("#amount").val(ui.values[0] + "đ - " + ui.values[1]+'đ');
    }
});
$("#amount").val($("#slider-range").slider("values", 0) +
    "đ - " + $("#slider-range").slider("values", 1) + 'đ');

function ClickToDown(idInput) {
    var value = $(idInput).val();
    if (value >1) {
        value--;
        $(idInput).val(value);
    }
    else {
        alert("Chỉ được chọn trong khoảng từ 1 -> 100");
        $(idInput).val(1);
    }
}
function ClickToUp(idInput) {
    var value = $(idInput).val();
    if (value < 100) {
        value++;
        $(idInput).val(value);
    }
    else {
        alert("Chỉ được chọn trong khoảng từ 1 -> 100");
        $(idInput).val(100);
    }
}

function CheckInput(idInput) {
    var valueinput = $(idInput).val();
    if (!isNaN(valueinput)) {
        if (parseInt(valueinput) < 2 || valueinput > 100) {
            alert("Chỉ được nhập giá trị trong khoảng từ 1-100");
            $(idInput).val(1);
        }
    }
    else {
        alert("Chỉ được số nguyên dương");
        $(idInput).val(1);
    }
}

function likeProduct() {
    $('.btn-like').toggleClass('active');
}

//function LoginAction() {
//    $("#LoginModal").modal('show'); 
//}