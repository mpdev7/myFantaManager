
window.onscroll = function () { scrollFunction() };

$('#scrollBtn').click(function (e) {
    e.preventDefault();

    $('body').animate({ scrollTop: 0 }, 300);
});

function scrollFunction() {
    if (document.body.scrollTop > 250 || document.documentElement.scrollTop > 250) {
        document.getElementById("scrollBtn").style.display = "block";
    }
    else {
        document.getElementById("scrollBtn").style.display = "none";
    }
}
