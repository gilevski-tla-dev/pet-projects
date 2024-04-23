import styles from "./vacancies_card.module.css";

const VacanciesCard = () => {
  return (
    <div className={styles.content}>
      <div className={styles.card}>
        <div className={styles.image_container}>
          <img src="/baker.png" alt="Постер" />
        </div>
        <div className={styles.description_container}>
          <div className={styles.title}>Пекарь</div>
          <div className={styles.description_title}>Описание вакансии</div>
          <div className={styles.description_block}>
            <h1 className={styles.description_text}>
              Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
              eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
              enim ad minim veniam, quis nostrud exercitation ullamco laboris
              nisi ut
            </h1>
          </div>
          <div className={styles.requirements_title}>Требования</div>
          <div className={styles.requirements_block}>
            <h1 className={styles.requirements_text}>
              Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do
              eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut
              enim ad minim veniam
            </h1>
          </div>
        </div>
      </div>
    </div>
  );
};

export default VacanciesCard;
