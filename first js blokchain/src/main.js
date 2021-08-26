const {Blockchain} = require('./Blockchain');
const {Transaction} = require('./Transaction')
const EC= require('elliptic').ec; 
const ec = new EC('secp256k1')


const myKey= ec.keyFromPrivate('ec3c110666905b9c7abef670c3b294aac620db13c7d52c3a29013fd85d45eb27')
const myWalletAdress = myKey.getPublic('hex');
 let bCoin= new Blockchain();


for(let i=0;i<=10;i++){
    const tx= new Transaction(myWalletAdress,'public key goes here', 10);
    tx.signTransaction(myKey);
    bCoin.addTransaction(tx); 
}



    console.log('\n starting the miner...')
    bCoin.minePendingTransactions(myWalletAdress);
 

   console.log( bCoin.getBalanceOfAdress(myWalletAdress))


   bCoin.chain[1].transactions[0].amount=1;

   console.log('is chain Valid?',bCoin.isChainValid());

