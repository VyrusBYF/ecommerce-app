import { Button, Container, Form, Nav, Navbar } from "react-bootstrap";

export const Header = (): JSX.Element => {
  const num = 0;
  return (
    <Navbar
      bg="dark"
      className="fixed-top"
      variant="dark">
      <Container>
        <Navbar.Brand href="#home">
          <img
            alt="Your Logo"
            src="/logo.svg"
            width="30"
            height="30"
            className="d-inline-block align-top"
          />{" "}
          Insert Brand Name Here
        </Navbar.Brand>
        <Nav>
          <Nav.Link href="#">Link</Nav.Link>
          <Nav.Link href="#">Link</Nav.Link>
          <Nav.Link href="#">Link</Nav.Link>
          <Nav.Link href="#">Link</Nav.Link>
        </Nav>
      </Container>
    </Navbar>
  );
};
