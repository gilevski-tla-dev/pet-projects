import styles from "./black_card.module.css";
import CardPopup from "../card_popup/CardPopup";
import { useState } from "react";

const Black_card = () => {
  const [isPopupOpen, setPopupOpen] = useState(false);
  return (
    <div className={styles.card}>
      <div
        onClick={() => {
          setPopupOpen(true);
        }}
      >
        <div className={styles.title_container}>
          <h1 className={styles.title}>Блинчики </h1>
          <div className={styles.stars}>
            <img src="/yellow_star.svg" alt="star" className={styles.star1} />
            <img
              src="/purple_star.svg"
              alt="purple_star"
              className={styles.star_purple}
            />
            <img src="/yellow_star.svg" alt="star2" className={styles.star2} />
          </div>
        </div>
        <div className={styles.img_container}>
          <div className={styles.img_border}>
            <img className={styles.img_pancake} src="/pancake1.png" />
          </div>
        </div>

        <div className={styles.info_container}>
          <div className={styles.price_container}>
            <span className={styles.price}>1000</span>
          </div>
          <div className={styles.info_block}>
            <h3 className={styles.kilos}>5129</h3>
            <h3 className={styles.gram}>1500</h3>
          </div>
        </div>
      </div>
      <CardPopup
        isPopupOpen={isPopupOpen}
        setPopupOpen={setPopupOpen}
      ></CardPopup>
    </div>
  );
};

export default Black_card;
