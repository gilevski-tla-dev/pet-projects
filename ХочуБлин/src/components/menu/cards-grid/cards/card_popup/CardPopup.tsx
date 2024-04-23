import React, { useState } from "react";
import styles from "./card_popup.module.css";

interface CardPopupProps {
  isPopupOpen: boolean;
  setPopupOpen: React.Dispatch<React.SetStateAction<boolean>>;
}

const CardPopup: React.FC<CardPopupProps> = ({ isPopupOpen, setPopupOpen }) => {
  if (!isPopupOpen) return <></>;

  const [view, setView] = useState(true);
  const closeModal = () => {
    setView(false);
    setTimeout(() => {
      setPopupOpen(false);
    }, 300);
  };

  return (
    <div className={styles.popup_overlay}>
      <div className={styles.wrapper}>
        <div
          className={`${styles.container}  ${
            !view ? styles.close : styles.open
          }  `}
        >
          <svg
            onClick={closeModal}
            className={styles.exit_btn}
            width="20"
            height="20"
            viewBox="0 0 20 20"
            fill="none"
            xmlns="http://www.w3.org/2000/svg"
          >
            <path
              d="M1.7583 18.1055L18.364 1.55205"
              stroke="#FFE600"
              strokeWidth="2"
              strokeLinecap="round"
            />
            <path
              d="M18.1011 18.2095L1.49542 1.65605"
              stroke="#FFE600"
              strokeWidth="2"
              strokeLinecap="round"
            />
          </svg>
          <div className={styles.first_container}>
            <div className={styles.image_block}>
              <img src="/pancake1.png" alt="Постер" />
            </div>
            <div className={styles.title_block}>
              <h1 className={styles.title}>Блинчики с ягодами и инжиром</h1>
              <div className={styles.info_block}>
                <h3 className={styles.gram}>300</h3>
                <h3 className={styles.kilos}>512</h3>
              </div>
            </div>
          </div>
          <h1 className={styles.about_title}>Описание</h1>
          <div className={styles.about}>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
            eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim
            ad minim veniam eiusmod tempor incididunt ut labore et dolore magna
            aliqua. Ut enim ad minim veniam
          </div>
          <div className={styles.price_container}>
            <h2>Цена :</h2>
            <h3>500</h3>
            <svg
              width="57"
              height="8"
              viewBox="0 0 57 8"
              fill="none"
              xmlns="http://www.w3.org/2000/svg"
            >
              <line
                y1="-0.5"
                x2="55.5724"
                y2="-0.5"
                transform="matrix(0.993766 -0.111484 0.120446 0.99272 1 7.29639)"
                stroke="white"
              />
            </svg>
            <h4>1000</h4>
          </div>
        </div>
      </div>
    </div>
  );
};

export default CardPopup;
