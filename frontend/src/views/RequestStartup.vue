<template>
  <v-container>
    <div>
      <h1 class="mt-6">Оставить заявку</h1>
      <div class="mt-4 w-60">
        <h3>Что болит?</h3>
        <v-textarea
          name="input-7-1"
          placeholder="Опишите своими словами существующую в организации проблему. Можно сформулиро-вать проблему в форму задачи"
          outlined
          class="mt-1"
        ></v-textarea>
      </div>
      <div class="mt-4 w-60">
        <h3>Как проявляется ваша проблема?</h3>
        <v-textarea
          name="input-7-1"
          placeholder="Приведите описание реальной ситуации, в которой проблема бы проявилась"
          outlined
          class="mt-1"
        ></v-textarea>
      </div>
      <div class="mt-4 w-60">
        <h3>Что будет если проблему не решать?</h3>
        <v-textarea
          name="input-7-1"
          placeholder="Опишите нежелательные эффекты, которые возникают или могут возникнуть из-за того, что проблема не решается"
          outlined
          class="mt-1"
        ></v-textarea>
      </div>
      <div class="mt-4 w-60">
        <h3>Почему так происходит?</h3>
        <v-textarea
          name="input-7-1"
          placeholder="Какие на ваш взгляд ключевые причины воз-никновения проблемы? Что на ваш взгляд яв-ляется причиной возникновения проблемы?"
          outlined
          class="mt-1"
        ></v-textarea>
      </div>
      <div class="mt-4 w-60">
        <h3>У кого болит?</h3>
        <v-textarea
          name="input-7-1"
          placeholder="Кто является непосредственно ответственным за проблемный участок?"
          outlined
          class="mt-1"
        ></v-textarea>
      </div>
      <div class="mt-4 w-60">
        <h3>Какой желательный срок решения проблемы?</h3>
        <v-slider
          class="mt-10"
          :hint="years"
          persistent-hint
          max="120"
          min="0"
          v-model="monthsCount"
        ></v-slider>
      </div>
      <div class="mt-10 w-60">
        <h3>Пробовали решать?</h3>
        <v-textarea
          name="input-7-1"
          placeholder="Как пытались решить проблему ранее? Почему эти попытки оказались неудачными или почему были признаны неудачными? Чем не устроили найденные решения?
Общались ли с рынком? Если да, то с кем?
"
          outlined
          class="mt-1"
        ></v-textarea>
      </div>
      <div class="mt-4 w-60">
        <h3>Как с вами связаться?</h3>
        <div class="mt-6">
          <v-textarea
            name="input-7-1"
            placeholder="Наименование вашего предприятия"
            auto-grow
            outlined
            rows="1"
            row-height="12"
            class="mt-1 w-60"
          ></v-textarea>
        </div>
        <div class="mt-1">
          <v-textarea
            name="input-7-1"
            auto-grow
            placeholder="Ваши ФИО"
            outlined
            rows="1"
            row-height="12"
            class="mt-1 w-60"
          ></v-textarea>
        </div>
        <div class="mt-1">
          <div>Телефон для связи</div>
          <v-textarea
            name="input-7-1"
            auto-grow
            outlined
            rows="1"
            row-height="12"
            class="mt-1 w-60"
          ></v-textarea>
        </div>
      </div>
      <v-btn color="primary">Отправить</v-btn>
    </div>
  </v-container>
</template>

<script>
function declOfNum(n, text_forms) {
  n = Math.abs(n) % 100;
  var n1 = n % 10;
  if (n === 0 || n === undefined) return "";
  if (n > 10 && n < 20) {
    return text_forms[2];
  }
  if (n1 > 1 && n1 < 5) {
    return text_forms[1];
  }
  if (n1 == 1) {
    return text_forms[0];
  }
  return text_forms[2];
}
export default {
  data: () => ({
    text: "",
    monthsCount: 0,
  }),
  computed: {
    years() {
      const months = this.monthsCount % 12;
      const years = (this.monthsCount / 24).toFixed(0);
      const wordYear = declOfNum(years, ["год", "года", "лет"]);
      const wordMonth = declOfNum(months, ["месяц", "месяца", "месяцев"]);

      return `Длительность ${Number(years) || ""} ${wordYear} ${
        Number(months) || ""
      } ${Number(months) ? wordMonth : ""}`;
    },
  },
};
</script>
<style scoped>
.w-60 {
  width: 60%;
}
.w-40 {
  width: 40%;
}
</style>