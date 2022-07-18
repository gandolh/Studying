/// <reference types="cypress"/>

//swift of tests
describe('good_title', ()=>{
    //individual tests
    // it('First test',()=>{ 
    //     // cy.viewport(1000,600)
    //     // cy.visit('https://sighack.com/');
    //     // cy.contains('Sketch').should('exist');
    //     // cy.get('span.logo-prompt').should('exist');
    //     // cy.get('span.asd').should('not.exist');
    //     // cy.get('span[class=logo-prompt]').should('exist');
    //     // cy.get('a').first().click();
    // });

    // it('Run test for PC',()=>{
    //     cy.viewport(1280,720);
    //     cy.visit('https://www.w3schools.com/css/css3_buttons.asp');
    // })

    // it('Run test for mobile',()=>{
    //     cy.viewport('iphone-8');
    //     cy.visit('https://www.w3schools.com/css/css3_buttons.asp');            
    // })

    // it('second test', ()=>{
    //     cy.visit('https://www.w3schools.com/css/css3_buttons.asp');
    //     cy.get('#sn-b-custom').click();
    //     cy.get('#sn-b-save').click(); 
    //     // cy.get('.btn.w3-green').should('have.text','CSS Button')
    // })

    // it('login page looks good',()=>{
    //     cy.url().then((value)=>{
    //         cy.log('The current Real url is: ',value);
    //     })

    //     cy.contains('Log in').click();
    //     cy.contains('Log in').should('exist');
    //     cy.contains('Email').should('exist');
    //     cy.log('going to forgot password');
    //     cy.contains('Forgot password?').click();
    //     cy.url().should('include','reset');
    //     cy.go('back')
    // })


    it('Login should work fine', ()=>{
        cy.viewport(1280,720);
        cy.visit('https://www.w3schools.com/css/css3_buttons.asp');
            cy.get('#sn-b-custom').click();
            cy.get('#sn-b-save').click();
            cy.contains('Log in').click();
            cy.get('#modalusername').type('Admin');
            cy.get('#current-password').type('Admin');
    })
})