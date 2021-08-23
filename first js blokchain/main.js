var SHA256 = require('crypto-js/sha256.js');


class Block{
    constructor(index,timestamp,data,previousHash = ''){
        this.index= index;
        this.timestamp= timestamp;
        this.data =data;
        this.previousHash = previousHash;
        this.hash = this.calculateHash();
        this.nonce = 0;

    }
    calculateHash(){
        return SHA256(this.index + this.previousHash+ this.timestamp +JSON.stringify(this.data) + this.nonce).toString(); 
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
     }
     createGenesisBlock(){
        let curentDate= this.getCurrentDateAsString();
         return new Block(0, curentDate,'Genesis block',"0")
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
     
     addBlock(newBlock){
        newBlock.previousHash = this.getLatestBlock().hash;
        newBlock.mineBlock(this.difficulty);
        this.chain.push(newBlock);
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
 bCoin.addBlock(new Block(bCoin.chain.length,bCoin.getCurrentDateAsString, {amount:parseInt(Math.random(10))}))
 
// console.log('is blockchain valid?' , bCoin.isChainValid())

// bCoin.chain[1].data = 'asd';
// bCoin.chain[1].hash=bCoin.chain[1].calculateHash();
// console.log('is blockchain valid?' , bCoin.isChainValid())

//  console.log(bCoin);