import React, { Component } from 'react';

export class CustomerManagement extends Component {
    displayName = CustomerManagement.name

    constructor(props) {
        super(props);
        this.state = {
            customers: [],
            loading: true,
        };

        fetch('api/Customer/GetCustomer', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
            },
            body: null,
        })
        .then(response => response.json())
        .then(data => {
            this.setState({
                customers: data,
                loading: false,
            });
        });
    }

    renderCustomerLists = (customers) => {
        if (!customers) return null;

        return (
            customers.map(customer =>
                <tr key={customer.customerid}>
                    <td>{customer.customerid}</td>
                    <td>{customer.customerName}</td>
                    <td>{customer.email}</td>
                    <td>{customer.mobileNo}</td>
                    <td>View Transactions</td>
                </tr>
            ));
    }

    renderCustomerTable = (customers) => {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Customer ID</th>
                        <th>Customer Name</th>
                        <th>Contact Email</th>
                        <th>Mobile No</th>
                        <th>Transactions</th>
                    </tr>
                </thead>
                <tbody>
                    {this.renderCustomerLists(customers)}
                </tbody>
            </table>
        );
    }

    render() {
        const contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderCustomerTable(this.state.customers);

        return (
            <div>
                <h1>Customer Management</h1>
                <p>See all customers available on database.</p>
                {contents}
            </div>
        );
    }
}
