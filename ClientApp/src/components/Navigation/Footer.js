import React from 'react';
import { Container, Row, Col, Button } from 'react-bootstrap';
import '../../Style/Footer.css';

export default function Footer() {
  return (
    <Container fluid className="footerContainer">
      <Row className="newsletterRow text-center">
        <Col>
          <h2>Subscribe to our Newsletter</h2>
          <form>
            <input type="email" placeholder="Email address" />
            <Button variant="outline-light" className="subscribeButton">Subscribe</Button>
          </form>
        </Col>
      </Row>
      <Row className="text-center">
        <Col>
          Created by: 
          <a className="gitLink" href="https://github.com/SerhanMiah" target="_blank" rel="noreferrer"> 
            <i className="fa-brands fa-github"></i> Serhan Miah 
          </a>
        </Col>
      </Row>
    </Container>
  );
}
