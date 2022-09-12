function showOrHide(){

    var elements = document.getElementsByClassName('eng');

    var display = elements[0].style.display;
    var show = display == 'block' || display == undefined || display == null || display == '' 
               ?'none'
               :'block';

    for (let index = 0; index < elements.length; index++) {
        const element = elements[index];                  
        element.style.display = show;                 
    }
}
 
document.body.addEventListener('click', function (e) {

    if (e.target.tagName == 'SPAN' ){
        e.target.nextElementSibling.style.display = 'inline';
        e.target.style.display = 'none';
    }
    if (e.target.className == 'rus' && e.target.nextElementSibling.style.display == 'block') {
        e.target.nextElementSibling.style.display = 'none'; 
    }

    else if (e.target.className == 'rus') {
        e.target.nextElementSibling.style.display = 'block'; 
    }

}, false);

function speech(event) {
    if ('speechSynthesis' in window) {

        var res = event.target
            .innerText
            .replace('sth', 'something')
            .replace('/', 'or')
            .replace('sb', 'somebody')
            .replace('*','').replace('*','').replace('*','');

        var utterance = new SpeechSynthesisUtterance(res);
        utterance.lang = "en-US";
        //utterance.lang = "ru-RU";
        window.speechSynthesis.speak(utterance);
    }
}

var items = document.getElementsByClassName('eng');

for (var i = 0; i < items.length; i++) {

    items[i].addEventListener('click', speech); 
}

function showAnswer() {

    var spans = document.getElementsByTagName("span");

    for(var i = 0; i < spans.length; i++){            
        var span = spans[i];
        span.style.display = 'none';
    }

    var iii = document.getElementsByTagName("i");
    for(var i = 0; i < iii.length; i++){
        var ii = iii[i];
        ii.style.display = 'inline';
    }
}