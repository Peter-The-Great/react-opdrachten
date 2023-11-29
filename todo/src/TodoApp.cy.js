import TodoApp from './TodoApp'
import React from 'react'

describe('ToDo App Tests', () => {
  beforeEach(() => {
    cy.mount(<TodoApp />);
    cy.get('input[type="text"]').should('be.visible');
  });

  it('Voegt een taak toe aan de lijst', () => {
    const todoText = 'Nieuwe taak toevoegen';
    cy.get('input[type="text"]').type(todoText);
    cy.get('button').contains('Add').click();
    cy.get('.todo-list').should('contain', todoText);
  });


  it('Verwijdert een taak uit de lijst', () => {
    const todoText = 'Taak om te verwijderen';

    cy.get('input[type="text"]').type(todoText);
    cy.get('button').contains('Add').click();
    cy.get('.todo-list').should('contain', todoText);

    cy.get('.todo-list li').contains(todoText).parent().find('button').click();
    cy.get('.todo-list').should('not.contain', todoText);
  });
});
