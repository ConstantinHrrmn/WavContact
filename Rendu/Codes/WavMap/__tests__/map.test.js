// EXEMPLE
// const app = require('../app.js');  // prendre ce qu'on veut tester
//
// describe('palindrom', () =>{  // donner nom de ce qu'on veut tester
//   it('should retrieve a sentence', () =>{  // récupérer
//     expect(app.sentence.length).toBeGreaterThan(0);  // test  -> Il est possible d'utiliser toBe(), toBeCloseTo(), toEqual(), toStrictEqual(), toThrowError(), ...
//   });
//   it('should have a length of 1 letters', ()=>{
//     expect(app.sentence.length).toEqual(1);
//   })
// });
//  VOIR AUSSI  : https://jestjs.io/fr/docs/getting-started
// SI ON VEUT TESTER METTRE EN LIGNE DE COMMANDE A LA RACINE DE NOTRE DOSSIER MAP : npm t

// https://www.youtube.com/watch?v=8l-5pjZAxEY&ab_channel=codeconcept  -> idée de concept d'un jest

// 
// const testMap = require('../js/map.js');
//
// describe('it is to show a marker', ()=>{
//   expect(map).toHaveBeenCalledTimes(1);
//   expect(infoWindow.setPosition).toHaveBeenCalledTimes(1);
//   expect(infoWindow.setPosition).toHaveBeenCalledWith({'lat':34, 'lng': -92});
//   expect(infoWindow.open).toHaveBeenCalledTimes(1);
// })
