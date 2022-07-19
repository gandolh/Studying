/// <reference types="cypress"/>

//swift of tests
describe('basic unauthenticated desktop test', ()=>{

    beforeEach(()=>{
        cy.viewport(1280,720);
        cy.visit('https://www.w3schools.com/css/css3_buttons.asp');
    })

    it('Login should work fine', ()=>{
        
            cy.get('#sn-b-custom').click();
            cy.get('#sn-b-save').click();
            cy.contains('Log in').click();
            cy.get('#modalusername').type('Admin');
            cy.get('#current-password').type('Admin');
    })

    it('Login should work fine_2', ()=>{
        
        cy.get('#sn-b-custom').click();
        cy.get('#sn-b-save').click();
        cy.contains('Log in').click();
        cy.get('#modalusername').type('Admin');
        cy.get('#current-password').type('Admin');
})
})