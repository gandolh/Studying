/// <reference types="cypress"/>
import secretData from './secret.json'
describe('empty spec', () => {

  before(()=>{
    cy.visit(secretData.secret_url)
  })

  it('accept cookies', ()=>{
    cy.get('#sn-b-custom').click();
    cy.get('#sn-b-save').click();
  })

  it('Login', () => {
    cy.contains('Log in').click();
    cy.get('#modalusername').type(secretData.email);
    cy.get('#current-password').type(secretData.password);
    cy.contains('Log in').click();
    cy.location('origin').should('contain','w3school')
  })
})