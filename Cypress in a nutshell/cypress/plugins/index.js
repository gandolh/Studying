const {clearDatabase} = require('../../server/db');

module.exports = (on,config) =>{
    on('task',{
        'clear:db' : ()=>{
            return clearDatabase(); 
        }
    })
}