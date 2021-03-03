import * as React from 'react';

export default class SideBar extends React.PureComponent<{}, { isOpen: boolean }> {
    public state = {
        isOpen: false
    };

    public render() {
        return (
            <aside className="sidebar col-12 col-md-4">
                <div className="sidebar-item">
                    <p>
                        <a
                            className="btn btn-outline-secondary"
                            data-bs-toggle="collapse"
                            href="#collapseExample"
                            role="button"
                            aria-expanded="false"
                            aria-controls="collapseExample"
                        >
                            Employment type
                            </a>
                    </p>
                    <div className="collapse" id="collapseExample">
                        <div className="card card-body">
                            <div className="form-check">
                                <input
                                    className="form-check-input"
                                    type="checkbox"
                                    value=""
                                    id="flexCheckDefault"
                                />
                                <label
                                    className="form-check-label"
                                //for="flexCheckDefault"
                                >
                                    Full time
                                    </label>
                            </div>

                            <div className="form-check">
                                <input
                                    className="form-check-input"
                                    type="checkbox"
                                    value=""
                                    id="flexCheckDefault"
                                />
                                <label
                                    className="form-check-label"
                                //for="flexCheckDefault"
                                >
                                    Part time
                                    </label>
                            </div>

                            <div className="form-check">
                                <input
                                    className="form-check-input"
                                    type="checkbox"
                                    value=""
                                    id="flexCheckDefault"
                                />
                                <label
                                    className="form-check-label"
                                //for="flexCheckDefault"
                                >
                                    Contractor
                                    </label>
                            </div>
                        </div>
                    </div>
                </div>
            </aside>
        );
    }

    private toggle = () => {
        this.setState({
            isOpen: !this.state.isOpen
        });
    }
}
