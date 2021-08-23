var SHA256 = require('crypto-js/sha256.js');

class Transaction{
    constructor(fromAdress, toAdress, amount){
        this.fromAdress = fromAdress;
        this.toAdress= toAdress;
        this.amount = amount;
    }


}
class Block{
    constructor(timestamp,transactions,previousHash = ''){
        this.timestamp= timestamp;
        this.transactions =transactions;
        this.previousHash = previousHash;
        this.hash = this.calculateHash();
        this.nonce = 0;

    }
    calculateHash(){
        return SHA256(this.previousHash+ this.timestamp +JSON.stringify(this.transactions) + this.nonce).toString(); 
    }

    mineBlock(difficulty){
        while(this.hash.substring(0,difficulty) != Array(difficulty+1).join("0")){
            this.nonce++;
            this.hash = this.calculateHash();
        }
        console.log("Block mined: "+ this.hash)
    }
}

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
        let block  = new Block(this.getCurrentDateAsString, this.pendingTransactions);

        //previous hash??
        block.mineBlock(this.difficulty);

        console.log('Block succesfully mined!' )
        this.chain.push(block);
        this.pendingTransactions=[
            new Transaction(null, miningRewardAdress, this.miningReward)
        ];

    }

    createTransaction(transaction){
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

             if(current.hash!== current.calculateHash())
             return false;
            if(current.previousHash!== prev.hash)
            return false; 
         }
         return true;
     }
 }

 let bCoin= new Blockchain();

for(let i=0;i<=10;i++)
    bCoin.createTransaction(new Transaction('adress'+parseInt(Math.random()*5),'adress'+parseInt(Math.random()*5),parseInt(Math.random()*100))) 



    console.log('\n starting the miner...')
    bCoin.minePendingTransactions('adress5');
 

for(let i=0;i<=5;i++){
   console.log( bCoin.getBalanceOfAdress('adress'+i) )
}

