import React from "react";

export const HeroBanner: React.FC = () => {
    const logo = "https://cdn.auth0.com/blog/developer-hub/react-logo.svg";
    //const displayName = Home.name;

  return (
    <div className="hero-banner hero-banner--pink-yellow">
          {/*<div className="hero-banner__logo">
        <img className="hero-banner__image" src={logo} alt="React logo" />
          </div>*/}

      <h1 className="hero-banner__headline">To:Writ</h1>
      <p className="hero-banner__description">
              <p>To:Writ is a journal site where you can update others about what's going on. Log in or create an account and start posting.</p>
      </p>
      <a
        id="code-sample-link"
        target="_blank"
        rel="noopener noreferrer"
        href="https://developer.auth0.com/resources/code-samples/spa/react/basic-authentication/typescript-react-router-6"
        className="button button--secondary"
      >
        Log In →
          </a>
          <a
              id="code-sample-link"
              target="_blank"
              rel="noopener noreferrer"
              href="https://developer.auth0.com/resources/code-samples/spa/react/basic-authentication/typescript-react-router-6"
              className="button button--secondary"
          >
              Sign Up →
          </a>
    </div>
  );
};
