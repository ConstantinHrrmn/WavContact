// researchTag est utilisé lors de la recherche des tags
fetch("https://waview.ch/wavcontact/map/php/researchTag.php")  // Lien qui contient les données
  .then(res=>res.json())  // réponse en format json
  .then(res=>{
    console.log(res);
  });
