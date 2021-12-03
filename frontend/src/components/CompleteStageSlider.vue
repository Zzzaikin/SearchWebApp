



<template>
  <div class="wrapper">
    <div class="my-3 wr">
      <span class="parameter-title">Стадия:</span>
      <span> {{ items.find((el) => el.num === completeStage).text }}</span>
    </div>
    <div class="stepper-wrapper">
      <template v-for="(item, i) in items">
        <div
          class="circle"
          :class="{ disabled: item.num > completeStage }"
          :key="item.num"
        >
          {{ item.num }}
        </div>

        <div
          class="line"
          :key="item.num + item.text"
          v-if="i + 1 !== items.length"
          :class="{ disabled: item.num > completeStage }"
        ></div>
      </template>
    </div>
  </div>
</template>

<script>
export default {
  props: ["completeStage"],
  data: () => ({
    items: [
      {
        num: 1,
        text: "Скрининг",
      },
      {
        num: 2,
        text: "Скоринг",
      },
      {
        num: 3,
        text: "Экспертный совет",
      },
      {
        num: 4,
        text: "Акселерационная программа",
      },
      {
        num: 5,
        text: "Программа пилотирования",
      },
      {
        num: 6,
        text: "Инвестирование",
      },
    ],
  }),
};
</script>
<style scoped>
.wrapper {
}
.stepper-wrapper {
  display: flex;
  flex-direction: row;
  align-items: center;
  width: 100%;
}
.hidden {
  visibility: hidden;
}
.circle {
  font-size: 12px;
  color: white;
  display: flex;
  justify-items: center;
  align-items: center;
  justify-content: center;
  width: 20px;
  height: 20px;
  border-radius: 50%;
  background-color: #009a96;
}
.line {
  width: 7%;
  height: 2px;
  background-color: #009a96;
}
.disabled {
  background-color: lightgray;
}
</style>











