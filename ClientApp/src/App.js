import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { CustomerManagement } from './components/CustomerManagement';

export default class App extends Component {
  displayName = App.name

    render() {
        return (
            <Layout>
                <Route exact path='/' component={CustomerManagement} />
            </Layout>
        );
    }
}
