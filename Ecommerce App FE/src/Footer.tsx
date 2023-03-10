import { Col, Container, Row } from "react-bootstrap";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import brand from "./_shared/brand";
import { faFacebook, faInstagram, faTwitter } from "@fortawesome/free-brands-svg-icons";
import { faEnvelope, faLocationDot, faMapMarker, faPhone, faShareNodes } from "@fortawesome/free-solid-svg-icons";
import { IconProp } from "@fortawesome/fontawesome-svg-core";
import { faEnvelopeOpen } from "@fortawesome/free-regular-svg-icons";

export const Footer = (): JSX.Element => {
  const num = 0;
  return (
    <footer className="fixed-bottom p-5 footer text-bg text-light">
      <Container>
        <Row>
          <Col
            id="footer-brand-info"
            md={6}
            xs={12}
            className="text-start">
            <Row className="pb-3">
              <h4>{brand.Name}</h4>
              <p>{brand.Description}</p>
            </Row>
            <Row className="">
              <Col>
                <FontAwesomeIcon icon={faLocationDot as IconProp} />
              </Col>
              <Col
                md={11}
                className="text-start">
                <p>{brand.Address}</p>
              </Col>
              <Col>
                <FontAwesomeIcon icon={faEnvelope as IconProp} />
              </Col>
              <Col
                md={11}
                className="text-start">
                <p>{brand.Email}</p>
              </Col>
              <Col>
                <FontAwesomeIcon icon={faPhone as IconProp} />
              </Col>
              <Col
                md={11}
                className="text-start">
                <p>Phone Number: (###) ###-####</p>
              </Col>
            </Row>
          </Col>
          <Col
            id="footer-information"
            md={3}
            xs={12}
            className="text-start">
            <Row>
              <Col>
                <h6>Information</h6>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>About Us</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Careers</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Delivery Options</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Privacy Policy</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Terms &amp; Conditions</p>
              </Col>
            </Row>
          </Col>
          <Col
            id="footer-customer-service"
            md={3}
            xs={12}
            className="text-start">
            <Row>
              <Col>
                <h6>Customer Service</h6>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Shipping Policy</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Help &amp; Contact Us</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Returns &amp; Refunds</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Online Stores</p>
              </Col>
            </Row>
            <Row>
              <Col>
                <p>Terms &amp; Conditions</p>
              </Col>
            </Row>
            <Row>
              <Col></Col>
            </Row>
          </Col>
        </Row>
      </Container>
      <hr />
      <Container>
        <Row className="text-start pt-4">
          <Col md={9}>
            <p>
              Copyright ©️
              <strong>
                <em>{brand.Name} </em>
              </strong>
              all rights reserved.
            </p>
          </Col>
          <Col>
            <Row className="d-flex justify-content-start w-75">
              <Col md={1}>
                <FontAwesomeIcon icon={faTwitter as IconProp} />
              </Col>
              <Col md={1}>
                <FontAwesomeIcon icon={faFacebook as IconProp} />
              </Col>
              <Col md={1}>
                <FontAwesomeIcon icon={faInstagram as IconProp} />
              </Col>
              <Col md={1}>
                <FontAwesomeIcon icon={faShareNodes as IconProp} />
              </Col>
            </Row>
          </Col>
        </Row>
      </Container>
    </footer>
  );
};
