import React, { Component } from 'react';

export class Api extends Component {
  static displayName = Api.name;

  constructor(props) {
    super(props);
    this.state = { booking: [], loading: true };
  }

  async populateBookingData() {
    const response = await fetch('booking');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }

  componentDidMount() {
    this.populateBookingData();
  }
}