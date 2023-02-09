var SHA256 = require('crypto-js/sha256.js');
const {Block} = require('./Block')
const {Transaction} = require('./Transaction')


 class Blockchain{
     constructor(){
         this.chain= [this.createGenesisBlock(),];
         this.difficulty = 2; 
         this.pendingTransactions = [];
         this.miningReward = 100;
     }
     createGenesisBlock(){
        let curentDate= this.getCurrentDateAsString();
         return new Block(curentDate,'Genesis block',"0")
     }
     getCurrentDateAsString(){
        const date = new Date();
        const DateArr= [date.getDate(), date.getMonth(),  date.getFullYear()];
        const dateString = DateArr.join('/');
        return dateString;
     }

     getLatestBlock(){
        return this.chain[this.chain.length-1];
     }
     
    minePendingTransactions(miningRewardAdress){
        const rewardTx = new Transaction(null, miningRewardAdress, this.miningReward);
         this.pendingTransactions.push(rewardTx);
        let block  = new Block(this.getCurrentDateAsString, this.pendingTransactions,this.getLatestBlock().hash);

        block.mineBlock(this.difficulty);

        console.log('Block succesfully mined!' )
        this.chain.push(block);
        this.pendingTransactions=[ ];

    }

    addTransaction(transaction){

        if(!transaction.fromAdress ||  !transaction.toAdress)
            throw new Error('Transaction must include from and to adress')

        if(!transaction.isValid())
            throw new Error('Cannot add invalid transaction to chain')
        
        
        if(this.getBalanceOfAdress(transaction.fromAdress)<transaction.amount)
            throw new Error('Invalid Balance')


         this.pendingTransactions.push(transaction);
    }

    getBalanceOfAdress(adress){
        let balance = 0;
        for(const block of this.chain){
            for(const trans of block.transactions){
                if(trans.fromAdress == adress )
                balance -=trans.amount;
                if(trans.toAdress == adress)
                balance += trans.amount;
            }

        }
        return balance;
    }

     isChainValid(){
         for(let i=1;i< this.chain.length;i++){
             const current = this.chain[i];
             const prev= this.chain[i-1];


            if(!current.hasValidTransactions()){
                return false;


            }
             if(current.hash!== current.calculateHash())
             return false;
            if(current.previousHash!== prev.hash)
            return false; 
         }
         return true;
     }
 }



 module.exports.Blockchain = Blockchain;