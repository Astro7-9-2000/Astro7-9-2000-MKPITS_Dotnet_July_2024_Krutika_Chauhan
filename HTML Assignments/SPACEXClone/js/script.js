const btn = document.getElementById('menu-btn');
const overlay = document.getElementById('overlay');
const menu = document.getElementById('mobile-menu');
const counters = document.querySelectorAll('.counter');
let scrollStarted = false;


images.forEach((image, index) => {
    image.style.opacity = index === currentIndex ? 1 : 0;
  });
  
  prevButton.addEventListener('click', () => {
    currentIndex = (currentIndex - 1 + images.length) % images.length;
    updateSlideshow();
  });
  
  nextButton.addEventListener('click', () => {
    currentIndex = (currentIndex + 1) % images.length;
    updateSlideshow();
  });
  
  function updateSlideshow() {
    images.forEach((image, index) => {
      image.style.opacity = index === currentIndex ? 1 : 0;
    });
  }

btn.addEventListener('click', navToggle);
document.addEventListener('scroll', scrollPage);

function navToggle() {
    btn.classList.toggle('open');
    overlay.classList.toggle('overlay-show');
    document.body.classList.toggle('stop-scrolling');
    menu.classList.toggle('show-menu');
}

function scrollPage() {
    const scrollPos = window.scrollY;
    
    if (scrollPos > 100 && !scrollStarted) {
        countUp();
        scrollStarted = true;
    } else if (scrollPos < 100 && scrollStarted) {
        reset();
        scrollStarted = false;
    }
}

function countUp() {
    counters.forEach((counter) => {
        console.log(counter);
        counter.innerText = '0';

        const updateCounter = () => {

            // Get count target
            const target = +counter.getAttribute('data-target');

            // Get current counter value
            const c = +counter.innerText;

            // create an increment
            const increment = target / 100;

            // If counter is less than the target , add the increment
            if (c < target) {
                // Round up and set counter value
                counter.innerText = `${Math.ceil(c + increment)}`;
                setTimeout(updateCounter, 75);
            } else {
                counter.innerText = target;
            }
        };
        updateCounter();
    });         
}

function reset() {
    counters.forEach((counter) => counter.innerHTML = '0');
}



    
