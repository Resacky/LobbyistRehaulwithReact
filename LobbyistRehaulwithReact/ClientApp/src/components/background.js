import React, { Component } from 'react';
import '../styles/LoginPageStyle/Background.css';

export class Background extends Component {
    static displayName = Background.name;

    render() {
        return (
            <>
                <body className="background">
                    {this.props.children}
                </body>
            </>
        );
    }
}
