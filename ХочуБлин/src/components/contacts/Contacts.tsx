import styles from "./contacts.module.css";

const Contacts = () => {
  return (
    <div className={styles.wrapper}>
      <div className={styles.info__container}>
        <div className={styles.info_title_text}>
          Вопросы? Пожелания? Предложения? Напиши нам!
        </div>
        <img className={styles.info_title} src="border.svg" alt="" />
        <div className={styles.info_title2}>
          Вопросы? Пожелания? Предложения? Напиши нам!
        </div>
        <div className={styles.info_block}></div>
      </div>
      <div className={styles.send_form__container}>
        <div className={styles.send_form_title}>Oбратная связь</div>
        <form className={styles.send_form}>
          <div className={styles.inputs}>
            <input
              className={styles.input}
              type="text"
              placeholder="Имя"
              maxLength={30}
            />
            <input className={styles.input} type="text" placeholder="Почта" />
          </div>
          <label className={styles.send_form__label}>Сообщение</label>
          <textarea className={styles.message_input} maxLength={300} />
          <button className={styles.send_button}>Отправить</button>
        </form>
      </div>
    </div>
  );
};

export default Contacts;
