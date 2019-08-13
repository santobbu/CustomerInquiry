import React, { Component } from 'react';
import { CustomerManagement } from './CustomerManagement';

export class RequestScenario extends Component {
    displayName = RequestScenario.name

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <CustomerManagement
                    title="Request Scenario #1"
                    customerId={123456}
                />

                <hr />

                <CustomerManagement
                    title="Request Scenario #2"
                    email="user01@mail.com"
                />

                <hr />

                <CustomerManagement
                    title="Request Scenario #3"
                    customerId={123456}
                    email="user01@mail.com" 
                />

            </div>
        );
    }
}
