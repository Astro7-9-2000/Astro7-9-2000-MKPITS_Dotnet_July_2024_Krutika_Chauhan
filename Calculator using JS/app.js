(function() {

    let screen = document.querySelector('.screen');    //This buttons are listed according to the sequence of execution of the user
    let buttons = document.querySelectorAll('.btn');  // For all number buttons only 1 function is created to take all the inputs by one button only
    let clear = document.querySelector('.btn-clear');
    let equal = document.querySelector('.btn-equal');

    buttons.forEach(function(button){                 
        button.addEventListener('click' , function(e){   /*EventListener is used to know which button was pressed and function will run if any event is acting.Here event name is click*/
        let value = e.target.dataset.num;  //
            screen.value += value;         // values are pushed to the screen
        })

    });

    equal.addEventListener('click' , function(e){
        if (screen.value === ''){
            screen.value = "Please Enter";
        }else{
            let answer = eval(screen.value);
            screen.value = answer;
        }
    })

    clear.addEventListener('click' , function(e){
        screen.value = "";
    });
        
})();