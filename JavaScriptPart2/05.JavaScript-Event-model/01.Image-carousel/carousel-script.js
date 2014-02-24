var carousel = (function(){

    var carousel = document.getElementById('carousel');
    var imgsCount = carousel.childElementCount;
    var imgs = carousel.getElementsByTagName('LI');

    function next(){
        for(var i = 0; i < imgs.length; i++){
            if(imgs[i].className !== "" && imgs[i].nodeName === "LI"){
                if(i + 1 == imgsCount){
                    imgs[i].className = "";
                    imgs[0].className = 'visible';
                } else{
                    imgs[i+1].className = 'visible';
                    imgs[i].className = "";
                }
                break;
            }
        }
    }

    function previous(){
        for(var i = 0; i < imgs.length; i++){
            if(imgs[i].className !== "" && imgs[i].nodeName === "LI"){
                if(i - 1 < 0){
                    imgs[i].className = "";
                    imgs[imgs.length - 1].className = 'visible';
                } else{
                    imgs[i - 1].className = 'visible';
                    imgs[i].className = "";
                }
                break;
            }
        }
    }

    return{
        next:next,
        previous: previous
    }
})();