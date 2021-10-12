const {Blockchain} = require('./Blockchain');
const {Transaction} = require('./Transaction')
const EC= require('elliptic').ec; 
const ec = new EC('secp256k1')




const myKey= ec.keyFromPrivate('ec3c110666905b9c7abef670c3b294aac620db13c7d52c3a29013fd85d45eb27')
const myWalletAdress = myKey.getPublic('hex');
let FoxyCoin= new Blockchain();
console.log(FoxyCoin)

//thats how it works
//  console.log(FoxyCoin.getBalanceOfAdress(myWalletAdress))
 
//  // console.log('\n starting the miner...')
//  FoxyCoin.minePendingTransactions(myWalletAdress);

//  console.log(FoxyCoin.getBalanceOfAdress(myWalletAdress))

// const tx= new Transaction(myWalletAdress,'public key goes here', 10);
// tx.signTransaction(myKey);
// console.log(tx)
// FoxyCoin.addTransaction(tx); 

// FoxyCoin.minePendingTransactions();
// console.log(FoxyCoin.getBalanceOfAdress(myWalletAdress))


