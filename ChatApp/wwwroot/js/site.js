var createRoomBtn = document.getElementById('create-room-btn')
var crateRoomModal = document.getElementById('create-room-modal')


//createRoomBtn.addEventListener('click', function () {
//    crateRoomModal.classList.add('active')
//})

function closeModal() {
    crateRoomModal.classList.remove('active')
}

$(".heading-compose").click(function () {
    $(".side-two").css({
        "left": "0"
    });
});

$(".newMessage-back").click(function () {
    $(".side-two").css({
        "left": "-100%"
    });
});

var chatScroll = document.getElementById("conversation");
chatScroll.scrollTop = chatScroll.scrollHeight - chatScroll.clientHeight;