

/// <reference types="cypress"/>

describe('editor test', () => {

    beforeEach(() => {
        cy.viewport(1280, 720);
        cy.visit('https://www.w3schools.com/css/tryit.asp?filename=trycss_buttons_basic');
        cy.get('#sn-b-custom').click();
        cy.get('#sn-b-save').click();
    })

    it('test editor',()=>{
        cy.get('.CodeMirror-code').type('{ctrl}{a}').type('{ctrl}{x}').type('asd');
    })

})