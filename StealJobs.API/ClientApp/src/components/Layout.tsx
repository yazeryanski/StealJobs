import * as React from 'react';
import logo from '../images/benivo.png';

export default class Layout extends React.PureComponent<{}, { children?: React.ReactNode }> {
    public render() {
        return (
            <React.Fragment>
                <div className="container">{this.props.children}</div>
            </React.Fragment>
        );
    }
}