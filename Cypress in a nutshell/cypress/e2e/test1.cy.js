/// <reference types="cypress"/>
import secretData from './secret.json'
describe('empty spec', () => {

  before(()=>{
    cy.visit(secretData.secret_url)
  })

  beforeEach(()=>{
    // to run js code outside of browser
    // cy.task('clear:db');
  })

  it('accept cookies', ()=>{
    cy.get('#sn-b-custom').click();
    cy.get('#sn-b-save').click();
  })

//   it('Login', () => {
//     cy.contains('Log in').click();
//     cy.login(secretData.email, secretData.password);
//     cy.location('origin').should('contain','w3school')
//   })

//   it('test third party apis',()=>{
//     cy.intercept({
//         method: 'GET',
//         url: '/users*',
//       })
      
//       // spying and response stubbing
//       cy.intercept('POST', '/test', {
//         statusCode: 403,
//         delay:3000,
//         body: {
//           name: 'Peter Pan',
//         },
//       })
//   })
})