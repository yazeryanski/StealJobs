import * as React from 'react';
import { connect } from 'react-redux';

const Home = () => (
    <div className="card mb-3">
        <div className="row g-0">
            <div className="col-md-4">
                <img
                    src="images/benivo.png"
                    alt="company logo"
                />
            </div>
            <div className="col-md-8">
                <div className="card-body">
                    <h5 className="card-title">
                        <a href="#">Senior Web Developer</a>
                    </h5>
                    <p className="card-text text-muted">
                        <span className="card-detail">
                            <i
                                className="fas fa-map-marker-alt"
                            ></i>
                                                Yerevan, Armenia
                                            </span>
                        <span className="card-detail">
                            <i className="fas fa-clock"></i>
                                                Full time
                                            </span>
                    </p>

                    <span className="card-buttons">
                        <a href="#" className="btn btn-warning">
                            <i className="fas fa-star text-light"></i>
                        </a>

                        <a href="#" className="btn btn-success">
                            Apply
                                            </a>
                    </span>
                </div>
            </div>
        </div>
    </div>
);

export default connect()(Home);
