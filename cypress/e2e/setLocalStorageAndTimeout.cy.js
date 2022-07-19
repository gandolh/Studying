/// <reference types="cypress"/>

const token = 'secret token';
describe('basic desktop test', () => {

    before(() => {
        cy.then(() => {
            window.localStorage.setItem('__auth_token__', token)
        })
    })
    beforeEach(() => {
        cy.viewport(1280, 720);
        cy.visit('https://www.w3schools.com/css/css3_buttons.asp');
        cy.get('#sn-b-custom').click();
        cy.get('#sn-b-save').click();


    })


    // it('Login should work fine', ()=>{
    //
    //          
    //         cy.contains('Log in').click();
    //         cy.get('#modalusername').type('Admin');
    //         cy.get('#current-password').type('Admin');
    // })


    // it('Local storage test', ()=>{
    //  
    //     cy.then(()=>{
    //         cy.log(window.localStorage.getItem('__auth_token__'))
    //     })
    //  
    //
    // })


    // it('freeze the js thread for debugging',()=>{
    //
    //     //do something
    //
    //     //block thread, it works only if console is open
    //     cy.debug();
    //
    //     //do something after continue
    // })


    // it('wait for loading screen',()=>{
    //     //imagine this is a loading screen
    //     //loading message present
    //     cy.get(".btn.btn3").should("contains.text",'Red')
    //     //loading message absent
    //     cy.get(".btn.btn3").should("not.contain.text",'Blue')
    //     // cy.get(".btn.btn3",{timeout:10 * 1000}).should("contain.text",'asd')
    // })



})