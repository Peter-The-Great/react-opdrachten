import React from 'react'
import Clock from './Clock'

describe('<Clock />', () => {
  it('renders', () => {
    // see: https://on.cypress.io/mounting-react
    cy.mount(<Clock />)
  })
})