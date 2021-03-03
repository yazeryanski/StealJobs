import * as React from 'react';

export default class Header extends React.PureComponent<{}, { isOpen: boolean }> {
    public state = {
        isOpen: false
    };

    public render() {
        return (
            <header className="header">
                <h1 className="header-title"><span>Job</span> finder</h1>

                <div className="filter-bar">
                    <select
                        className="form-select"
                        aria-label="Default select example"
                    >
                        <option selected>Category</option>
                        <option value="1">One</option>
                        <option value="2">Two</option>
                        <option value="3">Three</option>
                    </select>

                    <select
                        className="form-select"
                        aria-label="Default select example"
                    >
                        <option selected>Location</option>
                        <option value="1">One</option>
                        <option value="2">Two</option>
                        <option value="3">Three</option>
                    </select>

                    <div className="input-group">
                        <input
                            type="text"
                            className="form-control"
                            placeholder="Job title, description, company"
                            aria-label="Job title, description, company"
                            aria-describedby="button-addon2"
                        />
                        <button
                            className="btn btn-primary"
                            type="button"
                            id="button-addon2"
                        >
                            Search
                        </button>
                    </div>
                </div>
            </header>
        );
    }

    private toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }
}
