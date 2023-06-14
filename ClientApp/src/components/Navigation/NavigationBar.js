import React from 'react';
import { Navbar, Nav, NavDropdown, Form, FormControl, Button } from 'react-bootstrap';
// import 'bootstrap/dist/css/bootstrap.min.css';
import '../../Style/Navbar.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faUser } from '@fortawesome/free-solid-svg-icons';
import { useNavigate } from 'react-router-dom';


function NavigationBar() {

  const navigate = useNavigate();

  return (
    <Navbar collapseOnSelect expand="lg" bg="black" variant="dark">
      <Navbar.Brand href="#home">AnimeShop</Navbar.Brand>
      <Navbar.Toggle aria-controls="responsive-navbar-nav" />
      <Navbar.Collapse id="responsive-navbar-nav">
        <Nav className="mr-auto">
        <Nav.Link onClick={() => navigate('/products')}>All Products</Nav.Link>
          <NavDropdown title="Manga" id="collasible-nav-dropdown">
            <NavDropdown.Item href="#action/3.1">Shonen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.2">Shojo</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.3">Seinen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.4">Josei</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.5">Kodomomuke</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.6">Isekai</NavDropdown.Item>
          </NavDropdown>
          <NavDropdown title="DVD" id="collasible-nav-dropdown">
            <NavDropdown.Item href="#action/3.1">Shonen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.2">Shojo</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.3">Seinen</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.4">Josei</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.5">Kodomomuke</NavDropdown.Item>
            <NavDropdown.Item href="#action/3.6">Isekai</NavDropdown.Item>
          </NavDropdown>
          <Nav.Link href="#merchandise">Merchandise</Nav.Link>
          <Nav.Link href="#apparel">Apparel</Nav.Link>
        </Nav>
        <Form inline className="searchForm">
          <FormControl type="text" placeholder="Search" className="mr-sm-2" />
          <Button variant="outline-light">Search</Button>
        </Form>
        <Nav className="ml-auto">
          <Nav.Link href="#login">
            <FontAwesomeIcon icon={faUser} /> Login
          </Nav.Link>
          <Nav.Link href="#signup">
            <FontAwesomeIcon icon={faUser} /> Sign up
          </Nav.Link>
          <Nav.Link href="#cart">Cart</Nav.Link>
        </Nav>
      </Navbar.Collapse>
    </Navbar>
  );
}

export default NavigationBar;
