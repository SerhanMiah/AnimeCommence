import React, { useState } from 'react';
import axios from 'axios';
import { Container, Row, Col, Form, Button } from 'react-bootstrap';
import '../../Style/Login.css'

const Login = () => {
    const [user, setUser] = useState({Email: '', Password: ''});

    const handleChange = e => {
        setUser({...user, [e.target.name]: e.target.value });
    }

    const login = () => {
        axios.post('http://localhost:5000/api/account/login', user)
            .then(response => {
                console.log(response);
               
            })
            .catch(error => {
             
                console.log(error);
            });
    }

    return (
        <Container>
            <Row className="justify-content-md-center">
                <Col xs={12} md={6}>
                    <h1 className='text-center'>Login</h1>
                    <Form>
                        <Form.Group controlId="formEmail">
                            <Form.Label>Email address</Form.Label>
                            <Form.Control type="email" name="Email" placeholder="Enter email" onChange={handleChange} />
                        </Form.Group>

                        <Form.Group controlId="formPassword">
                            <Form.Label>Password</Form.Label>
                            <Form.Control type="password" name="Password" placeholder="Password" onChange={handleChange} />
                        </Form.Group>
                        <Button variant="primary" type="button" onClick={login} className='w-100'>
                            Login
                        </Button>
                    </Form>
                </Col>
            </Row>
        </Container>
    );
}

export default Login;
