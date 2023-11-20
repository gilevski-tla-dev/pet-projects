let phrases = [
    { text: 'Beautiful is better than ugly.', image: 'https://cs8.pikabu.ru/post_img/2016/02/17/10/145572598117693502.png' },
    { text: 'Explicit is better than implicit.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Simple is better than complex.', image: 'https://upload.wikimedia.org/wikipedia/ru/thumb/3/3f/%D0%93%D1%83%D0%B1%D0%BA%D0%B0_%D0%91%D0%BE%D0%B1_%D0%BF%D0%B5%D1%80%D1%81%D0%BE%D0%BD%D0%B0%D0%B6.png/778px-%D0%93%D1%83%D0%B1%D0%BA%D0%B0_%D0%91%D0%BE%D0%B1_%D0%BF%D0%B5%D1%80%D1%81%D0%BE%D0%BD%D0%B0%D0%B6.png' },
    { text: 'Complex is better than complicated.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Flat is better than nested.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Sparse is better than dense.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Readability counts.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: "Special cases aren't special enough to break the rules.", image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Although practicality beats purity.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Errors should never pass silently.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png' },
    { text: 'Unless explicitly silenced.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: 'In the face of ambiguity, refuse the temptation to guess.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: 'There should be one-- and preferably only one --obvious way to do it.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: "Although that way may not be obvious at first unless you're Dutch.", image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: 'Now is better than never.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: 'Although never is often better than *right* now.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: "If the implementation is hard to explain, it's a bad idea.", image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: 'If the implementation is easy to explain, it may be a good idea.', image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},
    { text: "Namespaces are one honking great idea -- let's do more of those!", image: 'https://free-png.ru/wp-content/uploads/2021/07/free-png.ru-61.png'},

  ];
  
  function getRandomElement(arr) {
    let randIndex = Math.floor(Math.random() * arr.length);
    return arr[randIndex];
  }
  
  let button = document.querySelector('.button');
  let phrase = document.querySelector('.phrase');
  let advice = document.querySelector('.advice');
  let image = document.querySelector('.image');
  
  button.addEventListener('click', function () {
    let randomElement = getRandomElement(phrases);
    smoothly(phrase, 'textContent', randomElement.text);
    smoothly(image, 'src', randomElement.image);
  
    if (randomElement.text.length > 40) {
      advice.style.fontSize = '33px';
    } else {
      advice.style.fontSize = '42px';
    }
  });
  
  for (let i = 0; i <= 9; i = i + 1) {
    smoothly(phrase, 'textContent', phrases[i].text);
    smoothly(image, 'src', phrases[i].image)
  } 