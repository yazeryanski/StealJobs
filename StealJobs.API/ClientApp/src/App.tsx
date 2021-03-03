import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Card from 'react-bootstrap/Card';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col'
import Button from 'react-bootstrap/Button'
import './main.css'

interface ICategory {
    categoryId: number;
    categoryName: Text;
}

interface ILocation {
    locationId: number;
    country: Text;
    region: Text;
    city: Text;
}

type State = {
    jobsResult: any;
    categories: any;
    locations: any;
    selectedLocationId: number;
    selectedCategoryId: number;
    query: Text;
};

type Props = {
};

const logo = require("./images/benivo.png")

export default class App<P = any, S = State> extends React.Component<P, S> {
    constructor(props: any) {
        super(props);
        this.state = {
            jobsResult: [],
            categories: [],
            locations: [],
            selectedLocationId: 0,
            selectedCategoryId: 0,
            query:""
        };

        this.onSearch = this.onSearch.bind(this);
        this.onLocationSelect = this.onLocationSelect.bind(this);
        this.onCategorySelect = this.onCategorySelect.bind(this);
        this.onKeywordChange = this.onKeywordChange.bind(this);
    }

    // After the component did mount, we set the state each second.
    componentDidMount() {


        fetch("../api/category").then(response => response.json())
            // ...then we update the users state
            .then(data => {
                this.setState({
                    categories: data,
                    isLoading: false
                })
            }
            ).catch(error => this.setState({ error, isLoading: false }));

        fetch("../api/location").then(response => response.json())
            // ...then we update the users state
            .then(data => {
                this.setState({
                    locations: data,
                    isLoading: false
                })
            }
            ).catch(error => this.setState({ error, isLoading: false }));
    }

    onSearch = () => {
        fetch(`../api/job/search?q=${this.state.query}&category=${this.state.selectedCategoryId}&location=${this.state.selectedLocationId}`).then(response => response.json())
            // ...then we update the users state
            .then(data => {
                this.setState({
                    jobsResult: data,
                    isLoading: false
                })
            }
            ).catch(error => this.setState({ error, isLoading: false }));
    }

    onCategorySelect = (e: any) => {
        this.setState({
            selectedCategoryId: e.target.value
        })
    }

    onLocationSelect = (e: any) => {
        this.setState({
            selectedLocationId: e.target.value
        })
    }

    onKeywordChange = (e: any) => {
        this.setState({
            query: e.target.value
        })
    }
    // render will know everything!
    render() {
        const { locations, categories, jobsResult } = this.state;
        return <Layout>
            <header className="header">
                <div className="filter-bar">
                    <select
                        className="form-control no-border-right"
                        onChange={this.onCategorySelect}
                        aria-label="Default select example"
                        defaultValue={0}
                    >
                        <option key="0" value="0">Please select category</option>)
                        {categories && categories.length > 0 ? categories.map((elem: ICategory) => <option key={elem.categoryId} value={elem.categoryId}>{elem.categoryName}</option>) : null}
                    </select>

                    <select
                        className="form-control no-border-right no-border-left"
                        aria-label="Default select example"
                        onChange={this.onLocationSelect}
                        defaultValue={0}
                    >
                        <option key="0" value="0">Please select location</option>)
                        {locations && locations.length > 0 ? locations.map((elem: ILocation) => <option key={elem.locationId} value={elem.locationId}>{elem.country}, {elem.region}, {elem.city}</option>) : null}
                    </select>

                    <div className="input-group">
                        <input
                            type="text"
                            className="form-control no-border-right no-border-left"
                            placeholder="Job title, description, company"
                            aria-label="Job title, description, company"
                            aria-describedby="button-addon2"
                            onChange={this.onKeywordChange}
                        />
                        <button
                            className="btn btn-success no-border-left"
                            type="button"
                            id="button-addon2"
                            onClick={this.onSearch}
                        >
                            Search
                        </button>
                    </div>
                </div>
            </header>

            {jobsResult && jobsResult.count > 0 ? <Row className="search-panel" xs={12} md={12} lg={12}>
                <Col md={3}>
                    <Card>
                    </Card>
                </Col>
                <Col md={9} >
                    <Card className="search-result-panel">
                        <Card.Title>Showing {jobsResult.count} of {jobsResult.count} offers</Card.Title>
                        <Card.Body>
                            {jobsResult.data.map((job: any) => {
                                return <Row className="job-item" xs={12} md={12} lg={12} >
                                    <Col md={3}> <img src={logo} />  </Col>
                                    <Col md={6}>
                                        <h2>{job.title}</h2>
                                        <p>{job.location.city}, {job.location.region}, {job.location.country}</p>
                                    </Col>
                                    <Col md={3} className="btn-container" >
                                        <Button variant="primary" >Bookmark</Button>
                                        <Button variant="success" >Apply for this job</Button>
                                    </Col>
                                </Row>

                            })}
                        </Card.Body>
                    </Card>
                </Col>
            </Row> : null
            }
        </Layout>
    }
}